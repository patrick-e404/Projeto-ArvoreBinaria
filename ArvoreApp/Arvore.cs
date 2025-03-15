using System;

namespace ArvoreApp
{
    public class Arvore
    {
        private Nodo _raiz;

        public void Adicionar(string valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_raiz == null)
            {
                _raiz = novoNodo;
            }
            else
            {
                Adicionar(novoNodo, _raiz);
            }
        }

        private void Adicionar(Nodo novoNodo, Nodo nodoReferencia)
        {
            if (string.Compare(novoNodo.Valor, nodoReferencia.Valor) > 0)
            {
                if (nodoReferencia.Maior == null)
                {
                    nodoReferencia.Maior = novoNodo;
                }
                else
                {
                    Adicionar(novoNodo, nodoReferencia.Maior);
                }
            }
            else
            {
                if (nodoReferencia.Menor == null)
                {
                    nodoReferencia.Menor = novoNodo;
                }
                else
                {
                    Adicionar(novoNodo, nodoReferencia.Menor);
                }
            }
        }

        public void MostrarCrescente()
        {
            if (_raiz == null)
            {
                Console.WriteLine("A árvore está vazia.");
                return;
            }
            MostrarCrescente(_raiz);
        }

        private void MostrarCrescente(Nodo nodoReferencia)
        {
            if (nodoReferencia == null)
            {
                return;
            }

            MostrarCrescente(nodoReferencia.Menor);
            Console.WriteLine(nodoReferencia.Valor);
            MostrarCrescente(nodoReferencia.Maior);
        }

        public void MostrarDecrescente()
        {
            if (_raiz == null)
            {
                Console.WriteLine("A árvore está vazia");
                return;
            }
            MostrarDecrescente(_raiz);
        }

        private void MostrarDecrescente(Nodo nodoReferencia)
        {
            if (nodoReferencia == null)
            {
                return;
            }

            MostrarDecrescente(nodoReferencia.Maior);
            Console.WriteLine(nodoReferencia.Valor);
            MostrarDecrescente(nodoReferencia.Menor);
        }

        public void Remover(string data)
        {
            _raiz = Remover(_raiz, data);
        }

        private Nodo Remover(Nodo nodoReferencia, string valor)
        {
            if (nodoReferencia == null)
            {
                return nodoReferencia;
            }

            if (string.Compare(valor, nodoReferencia.Valor) > 0)
            {
                nodoReferencia.Maior = Remover(nodoReferencia.Maior, valor);
            }
            else if (string.Compare(valor, nodoReferencia.Valor) < 0)
            {
                nodoReferencia.Menor = Remover(nodoReferencia.Menor, valor);
            }
            else
            {
                if (nodoReferencia.Menor == null)
                {
                    return nodoReferencia.Maior;
                }
                else if (nodoReferencia.Maior == null)
                {
                    return nodoReferencia.Menor;
                }
                var menor = ObterMenor(nodoReferencia.Maior);
                menor.Menor = nodoReferencia.Menor;
                return nodoReferencia.Maior;
            }

            return nodoReferencia;
        }

        private Nodo ObterMenor(Nodo nodoReferencia)
        {
            if (nodoReferencia.Menor == null)
            {
                return nodoReferencia;
            }
            else
            {
                return ObterMenor(nodoReferencia.Menor);
            }
        }
    }
}