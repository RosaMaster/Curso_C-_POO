# Exercicio 01
# Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

from utils.util import estoque

def main():

    print("******************************* CADASTRO PRODUTO ************************************")
    nome1 = input('Digite o nome do produto: ')
    codigo1 = input('Digite o código: ')
    quantidade1 = int(input('Digite a quantidade: '))
    preco1 = float(input('Digite o preço: '))

    produto1 = estoque(nome1, codigo1, quantidade1, preco1)

    print("******************************* EM ESTOQUE INIT *************************************")
    print(f"{produto1}")
    print("******************************* EM ESTOQUE END **************************************")

    print("******************************* PEDIDO VENDA ****************************************")
    
    if produto1.get_codigo() == input('Digite o código do produto: '):
        qproduto = produto1.get_quantidade()
        
        print(f"### EM ESTOQUE: {produto1.get_quantidade()} Un ###")
        
        qtdeCompra = int(input('Digite a quantidade pedido: '))

        if qtdeCompra > qproduto:
            print("Quantidade insuficiente em estoque")

        else:
            produto1.subtrair_estoque(qtdeCompra)

            print(f"### EM ESTOQUE: {produto1.get_quantidade()} Un ###")

            vproduto = produto1.get_preco()

            print(f"VALOR TOTAL: R$ {(vproduto*qtdeCompra):.2f}")

    print("******************************* VENDA FINALIZADA ************************************")

if __name__ == '__main__':
    main()
