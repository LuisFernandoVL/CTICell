using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using CelularCTI73B.Model.Entidades;
using CelularCTI73B.Model.Suporte;

namespace CelularCTI73B.Model.Servico
{
    public static class Servico
    {
        //Objetos-----------------------------------------------------------
        public static Fabricante objFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fab = new Fabricante();
            fab.Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]);
            fab.Nome = dtr["nome"].ToString();
            return fab;
        }
        public static Aparelho objAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho ap = new Aparelho();
            ap.Id_Aparelho = Convert.ToInt64(dtr["id_aparelho"]);
            ap.Modelo = dtr["modelo"].ToString();
            ap.Altura = Convert.ToInt16(dtr["altura"]);
            ap.Largura = Convert.ToInt16(dtr["largura"]);
            ap.Espessura = Convert.ToInt16(dtr["espessura"]);
            ap.Peso = Convert.ToInt16(dtr["peso"]);
            ap.Preco = Convert.ToDecimal(dtr["preco"]);
            ap.Quantidade = Convert.ToInt32(dtr["quantidade"]);
            ap.Desconto = Convert.ToInt16(dtr["desconto"]);

            ap.Fabricante = objFabricante(ref dtr);

            return ap;
        }
        public static Pedido objPedido(ref NpgsqlDataReader dtr)
        {
            Pedido ped = new Pedido();
            ped.Id_Pedido = Convert.ToInt64(dtr["id_pedido"]);
            ped.Datahorapedido = Convert.ToDateTime(dtr["datahorapedido"]);
            ped.Observacao = dtr["observacao"].ToString();
            ped.Aparelho = objAparelho(ref dtr);
            return ped;
        }
        //Salvar------------------------------------------------------------
        public static void Salvar(Aparelho a)
        {

            String sql;
            if (a.Id_Aparelho == 0)//Salva
            {
                sql = "INSERT INTO aparelho " +
                "(id_fabricante, modelo, largura, altura, espessura," +
                "peso, quantidade, preco, desconto) VALUES (" +
                a.Fabricante.Id_Fabricante + ", '" + a.Modelo + "', " + a.Largura +
                ", " + a.Altura + ", " + a.Espessura + ", " + a.Peso +
                ", " + a.Quantidade + ", " +
                a.Preco + ", " + a.Desconto + ")";
                ConexaoBanco.executar(sql);

            }
            else //Atualiza
            {
                sql = "UPDATE aparelho SET " +
                    "id_fabricante = " + a.Fabricante.Id_Fabricante + "," +
                    "modelo = '" + a.Modelo + "'," +
                    "largura = " + a.Largura + "," +
                    "altura = " + a.Altura + "," +
                    "espessura = " + a.Espessura + "," +
                    "peso = " + a.Peso + "," +
                    "quantidade = " + a.Quantidade + "," +
                    "preco = " + a.Preco + "," +
                    "desconto = " + a.Desconto +
                    "WHERE id_aparelho = " + a.Id_Aparelho;
                ConexaoBanco.executar(sql);
            }
        }
        public static void Salvar(Fabricante fab)
        {
            String sql;
            if (fab.Id_Fabricante == 0)
            {
                sql = "INSERT INTO fabricante (nome) VALUES ('" + fab.Nome + "')";
                ConexaoBanco.executar(sql);
            }
            else
            {
                sql = "UPDATE fabricante SET nome = '" + fab.Nome +
                    "' WHERE id_fabricante = " + fab.Id_Fabricante;
                ConexaoBanco.executar(sql);
            }
        }
        public static Pedido SalvarPedido(Aparelho ap, string observacao = "")
        {
            Pedido ped = new Pedido();
            ped.Aparelho = ap;
            NpgsqlDataReader dtr = ConexaoBanco.selecionar("SELECT CURRENT_TIMESTAMP AS dataHoraPostgres");
            dtr.Read();
            ped.Datahorapedido = Convert.ToDateTime(dtr["dataHoraPostgres"]);
            dtr.Close();
            ped.Observacao = observacao;
            string sql = "INSERT INTO pedido(id_aparelho, datahorapedido, " +
                          "observacao) values (" +
                          ped.Aparelho.Id_Aparelho + "," +
                          "'" + ped.Datahorapedido.ToString("yyyy-MM-dd hh:mm:ss") + "'," +
                          "'" + ped.Observacao + "')";
            ConexaoBanco.executar(sql);
            //Baixar o estoque do aparelho vendido
            ap.Quantidade--;
            Salvar(ap);
            return ped;
        }
        //Métodos de Busca--------------------------------------------------
        public static List<Aparelho> BuscarAparelho()
        {
            List<Aparelho> aparelho = new List<Aparelho>();

            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante ORDER BY id_aparelho";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                aparelho.Add(objAparelho(ref dr));
            }
            dr.Close();
            return aparelho;
        }
        public static List<Aparelho> BuscarAparelho(Int64 id)
        {
            List<Aparelho> aparelho = new List<Aparelho>();

            string sql = "SELECT * FROM aparelho WHERE aparelho.id_aparelho =" + id + ";";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                aparelho.Add(objAparelho(ref dr));
            }
            dr.Close();
            return aparelho;
        }
        public static List<Aparelho> BuscarAparelho(decimal precoMin, decimal precoMax)
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.preco BETWEEN " + precoMin.ToString().Replace(",", ".") +
                "AND " + precoMax.ToString().Replace(",", ".") +
                "ORDER BY preco";
            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                aparelho.Add(objAparelho(ref dr));
            }
            dr.Close();
            return aparelho;
        }
        public static List<Aparelho> BuscarAparelho(string modelo)
        {
            List<Aparelho> aparelho = new List<Aparelho>();

            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante " +
                 "WHERE modelo LIKE '%" + modelo + "%' ORDER BY modelo";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                aparelho.Add(objAparelho(ref dr));
            }
            dr.Close();
            return aparelho;
        }
        public static List<Aparelho> BuscarAparelho(Fabricante fab)
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE fabricante.id_fabricante = " + fab.Id_Fabricante +
                "ORDER BY fabricante.nome";

            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                aparelho.Add(objAparelho(ref dr));
            }
            dr.Close();
            return aparelho;
        }
        public static List<Fabricante> BuscarFabricante()
        {
            List<Fabricante> fabricante = new List<Fabricante>();
            string sql = "SELECT * FROM fabricante";
            NpgsqlDataReader dr = ConexaoBanco.selecionar(sql);
            while (dr.Read())
            {
                fabricante.Add(objFabricante(ref dr));
            }
            dr.Close();
            return fabricante;

        }
    }
}