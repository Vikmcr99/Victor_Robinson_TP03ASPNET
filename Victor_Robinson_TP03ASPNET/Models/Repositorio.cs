using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Victor_Robinson_TP03ASPNET.Models
{
    public static class Repositorio 
    {
        private static List<Aniversariante> allAniversariantes = new List<Aniversariante>
        {
            new Aniversariante(1, "José", "Freitas", new DateTime(2001/01/21)),
            new Aniversariante(2, "Ana", "Maria", new DateTime(1993/03/23)),
        };
        
        public static IEnumerable<Aniversariante> listaAniversariantes
        {
            get { return allAniversariantes; }
        }

        public static void Adicionar(Aniversariante aniversariante)
        {
            aniversariante.Id = allAniversariantes.Count + 1;
            allAniversariantes.Add(aniversariante);
        }

        public static void Deletar(Aniversariante aniversariante)
        {
            allAniversariantes.RemoveAll(x => x.Id == aniversariante.Id);
        }

        public static void Editar(int id, Aniversariante atualizado)
        {
            foreach(Aniversariante a in listaAniversariantes)
            {
                if(a.Id == id)
                {
                    a.Id = atualizado.Id;
                    a.Nome = atualizado.Nome;
                    a.Sobrenome = atualizado.Sobrenome;
                    a.Nascimento = atualizado.Nascimento;
                }
            }
        }

        public static Aniversariante GetId(int id)
        {
            Aniversariante getId = new Aniversariante();
            foreach(Aniversariante aniver in listaAniversariantes)
            {
                if(aniver.Id == id)
                    getId = aniver;
            }
            return getId;
        }

        public static List<Aniversariante> buscaAniver = new List<Aniversariante>();
        public static Aniversariante AchaAniversariante(string aniversariantePesquisa)
        {
            Aniversariante buscaAniversariante = new Aniversariante();
            foreach(Aniversariante aniversariante in listaAniversariantes)
            {
                if(aniversariante.Nome == aniversariantePesquisa)
                {
                    buscaAniversariante = aniversariante;
                    buscaAniver.Add(buscaAniversariante);
                }
            }
            return buscaAniversariante;

        }
        

    }
}
