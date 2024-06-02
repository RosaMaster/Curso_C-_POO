# Exercício 02.1
# Com base na tabela de preços ao lado, faça um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

'''
    + --------------------- + --------------------- + --------------------- +
    | CODIGO                | EPECIFICACAO          | PRECO                 |
    + --------------------- + --------------------- + --------------------- +
    | 1                     | Cachorro Quente       | R$ 4.00               |
    | 2                     | X-Salada              | R$ 4.50               |
    | 3                     | X-Bacon               | R$ 5.00               |
    | 4                     | Torrada Simples       | R$ 2.00               |
    | 5                     | Refrigerante          | R$ 1.50               |
    + --------------------- + --------------------- + --------------------- +
'''

from math import sqrt

def main():
    a, b, c = map(float, input().split())
    delta = b ** 2 - 4 * a * c
    if a == 0 or delta < 0:
        print('Impossivel calcular')
    else:
        r1 = (-b + sqrt(delta)) / (2 * a)
        r2 = (-b - sqrt(delta)) / (2 * a)
        print(f'R1 = {r1:.5f}')
        print(f'R2 = {r2:.5f}')

if __name__ == '__main__':
    main()
