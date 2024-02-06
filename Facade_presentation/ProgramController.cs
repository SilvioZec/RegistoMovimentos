using Microsoft.EntityFrameworkCore;
using RegistoMovimentos.Business_code;
using RegistoMovimentos.Business_data;
using RegistoMovimentos.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Facade_presentation
{
    internal class ProgramController
    {
        //============================================================================== INSTANCIA DBCONTEXT
        DBWorker db = new DBWorker();

        //============================================================================== CRUD CLIENTES
        public void add(Cliente cliente) { db.Add(cliente); db.SaveChanges(); }
        public void remove(Cliente cliente) { db.Remove(cliente); db.SaveChanges(); }
        public void update(Cliente cliente) { db.Update(cliente); db.SaveChanges(); }

        //============================================================================== CRUD MOVIMENTOS
        public void add(Movimento movimento)
        {
            //adiciona objeto tipo_movimento ao movimento
            Tipo_movimento tipo_movimento = db.Tipos_movimento.Find(movimento.Tipo_movimentoId);
            //adiciona objeto cliente ao movimento.cliente
            Cliente cliente = db.Clientes.Find(movimento.ClienteId);
            movimento.Cliente = cliente;
            db.Add(movimento);
            db.SaveChanges();
        }
        public void remove(int movimentoId) { Movimento movimento = db.Movimentos.Find(movimentoId); db.Remove(movimento); db.SaveChanges(); }
        public void update(Movimento movimento) { db.Update(movimento); db.SaveChanges(); }

        //============================================================================== LISTAGENS
        public List<Movimento_datagrid> listarMovimentos()
        {
            var movimentos = from m in db.Movimentos
                             join c in db.Clientes on m.ClienteId equals c.Id
                             join tm in db.Tipos_movimento on m.Tipo_movimentoId equals tm.Id
                             orderby m.Data
                             select new Movimento_datagrid
                             {
                                 Id = m.Id,
                                 Data = m.Data.ToString("dd/MM/yyyy"),
                                 Valor = m.Valor,
                                 Marcador = m.Marcador,
                                 Descricao = m.Descricao,
                                 Cliente = c.Designacao,
                                 TipoMovimento = tm.Descricao,
                                 Saldo_parcial = db.Movimentos
                                            //somar creditos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 2)
                                            .Sum(x => x.Valor)
                                        //somar debitos
                                        - db.Movimentos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 1)
                                            .Sum(x => x.Valor)
                             };
            return movimentos.ToList();
        }

        public List<Cliente> listarClientes() { return db.Clientes.ToList(); }

        public Movimento buscarMovimento(int id_movimento)
        {
            return db.Movimentos.Find(id_movimento);
        }

        public List<Saldo> listarSaldos(bool chkDebito, bool chkCredito)
        {
            var saldos = db.Clientes
                .Select(c => new Saldo
                {
                    Id = c.Id,
                    Nif = c.Nif,
                    Nome_Cliente = c.Designacao,
                    Saldo_tipo = "",
                    Valor = db.Movimentos
                        .Where(m => m.ClienteId == c.Id)
                        .Sum(m => m.Tipo_movimentoId == 2 ? m.Valor : -m.Valor)
                })
                .ToList();

            // Atualiza o campo Saldo_tipo com base no Valor calculado
            foreach (var saldo in saldos)
            {
                saldo.Saldo_tipo = saldo.Valor >= 0 ? "Crédito" : "Débito";
            }

            if (chkDebito && chkCredito)
            {
                // Mostrar todos os clientes
                return saldos;
            }
            else if (chkDebito)
            {
                // Mostrar apenas clientes em débito
                return saldos.Where(s => s.Valor < 0).ToList();
            }
            else if (chkCredito)
            {
                // Mostrar apenas clientes em crédito (exceto aqueles com saldo zero)
                return saldos.Where(s => s.Valor > 0).ToList();
            }
            else
            {
                // Mostrar apenas clientes com saldo zero
                return saldos.Where(s => s.Valor == 0).ToList();
            }
        }

        public List<Movimento_datagrid> listarMovimentosCliente(int idCliente)
        {
            var movimentos = from m in db.Movimentos
                             join c in db.Clientes on m.ClienteId equals c.Id
                             join tm in db.Tipos_movimento on m.Tipo_movimentoId equals tm.Id
                             where c.Id == idCliente
                             orderby m.Data
                             select new Movimento_datagrid
                             {
                                 Id = m.Id,
                                 Data = m.Data.ToString("dd/MM/yyyy"),
                                 Valor = m.Valor,
                                 Marcador = m.Marcador,
                                 Descricao = m.Descricao,
                                 Cliente = c.Designacao,
                                 TipoMovimento = tm.Descricao,
                                 Saldo_parcial = db.Movimentos
                                            //somar creditos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 2)
                                            .Sum(x => x.Valor)
                                        //somar debitos
                                        - db.Movimentos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 1)
                                            .Sum(x => x.Valor)
                             };
            return movimentos.ToList();
        }

        public List<Movimento_datagrid> listarMovimentosCliente(int idCliente, string ano)
        {
            var movimentos = from m in db.Movimentos
                             join c in db.Clientes on m.ClienteId equals c.Id
                             join tm in db.Tipos_movimento on m.Tipo_movimentoId equals tm.Id
                             where c.Id == idCliente && m.Data.Year.ToString() == ano // filtrar por ano
                             orderby m.Data
                             select new Movimento_datagrid
                             {
                                 Id = m.Id,
                                 Data = m.Data.ToString("dd/MM/yyyy"),
                                 Valor = m.Valor,
                                 Marcador = m.Marcador,
                                 Descricao = m.Descricao,
                                 Cliente = c.Designacao,
                                 TipoMovimento = tm.Descricao,
                                 Saldo_parcial = db.Movimentos
                                            //somar creditos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 2)
                                            .Sum(x => x.Valor)
                                        //somar debitos
                                        - db.Movimentos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 1)
                                            .Sum(x => x.Valor)
                             };
            return movimentos.ToList();
        }

        public List<Movimento_datagrid> listarMovimentosCliente(int idCliente, string ano, string mes)
        {
            var movimentos = from m in db.Movimentos
                             join c in db.Clientes on m.ClienteId equals c.Id
                             join tm in db.Tipos_movimento on m.Tipo_movimentoId equals tm.Id
                             where c.Id == idCliente
                                   && m.Data.Year.ToString() == ano
                                   && m.Data.Month.ToString() == mes // filtra por mes
                             orderby m.Data
                             select new Movimento_datagrid
                             {
                                 Id = m.Id,
                                 Data = m.Data.ToString("dd/MM/yyyy"),
                                 Valor = m.Valor,
                                 Marcador = m.Marcador,
                                 Descricao = m.Descricao,
                                 Cliente = c.Designacao,
                                 TipoMovimento = tm.Descricao,
                                 Saldo_parcial = db.Movimentos
                                        //somar creditos
                                        .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 2)
                                        .Sum(x => x.Valor)
                                        //somar debitos
                                        - db.Movimentos
                                        .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 1)
                                        .Sum(x => x.Valor)
                             };
            return movimentos.ToList();
        }

        public List<Saldo> listarClienteMarcador(char? marcador)
        {
            var saldos = db.Clientes
                .Where(c => marcador == null ? c.Marcador == null : c.Marcador == marcador)
                .Select(c => new Saldo
                {
                    Id = c.Id,
                    Nif = c.Nif,
                    Nome_Cliente = c.Designacao,
                    Saldo_tipo = "",
                    Valor = db.Movimentos
                        .Where(m => m.ClienteId == c.Id)
                        .Sum(m => m.Tipo_movimentoId == 2 ? m.Valor : -m.Valor)
                })
                .ToList();

            // Atualiza o campo Saldo_tipo com base no Valor calculado
            foreach (var saldo in saldos)
            {
                saldo.Saldo_tipo = saldo.Valor >= 0 ? "Crédito" : "Débito";
            }

            return saldos;
        }


        public List<Movimento_datagrid> listarMovimentoMarcador(char? marcador)
        {
            var movimentos = from m in db.Movimentos
                             join c in db.Clientes on m.ClienteId equals c.Id
                             join tm in db.Tipos_movimento on m.Tipo_movimentoId equals tm.Id
                             where m.Marcador == marcador
                             orderby m.Data
                             select new Movimento_datagrid
                             {
                                 Id = m.Id,
                                 Data = m.Data.ToString("dd/MM/yyyy"),
                                 Valor = m.Valor,
                                 Marcador = m.Marcador,
                                 Descricao = m.Descricao,
                                 Cliente = c.Designacao,
                                 TipoMovimento = tm.Descricao,
                                 Saldo_parcial = db.Movimentos
                                            //somar creditos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 2)
                                            .Sum(x => x.Valor)
                                        //somar debitos
                                        - db.Movimentos
                                            .Where(x => x.ClienteId == m.ClienteId && x.Data <= m.Data && x.Tipo_movimentoId == 1)
                                            .Sum(x => x.Valor)
                             };
            return movimentos.ToList();
        }

        public List<Saldo> listarSaldosData(DateTime data)
        {
            var saldos = db.Clientes
                .Select(c => new Saldo
                {
                    Id = c.Id,
                    Nif = c.Nif,
                    Nome_Cliente = c.Designacao,
                    Saldo_tipo = "",
                    Valor = db.Movimentos
                        .Where(m => m.ClienteId == c.Id && m.Data <= data) // Filtra movimentos com data menor ou igual à data fornecida
                        .Sum(m => m.Tipo_movimentoId == 2 ? m.Valor : -m.Valor)
                })
                .ToList();

            // Atualiza o campo Saldo_tipo com base no Valor calculado
            foreach (var saldo in saldos)
            {
                saldo.Saldo_tipo = saldo.Valor >= 0 ? "Crédito" : "Débito";
            }


            // Mostrar todos os clientes
            return saldos;

        }

        public List<string> listarAnosMovimentos()
        {
            List<string> anos = db.Movimentos.Select(m => m.Data.Year.ToString()).Distinct().ToList();
            // Adicionando a string "Todos" como primeiro elemento da lista
            anos.Insert(0, "Todos");
            return anos;
        }
    }
}
