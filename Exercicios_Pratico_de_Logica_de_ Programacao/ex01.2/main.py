# Exercicio01.2
# Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. Fórmula: ( area = π x raio² ). Considere o valor de π = 3.14159

from math import pi

def main():
    raio = float(input('Digite o valor do raio: '))
    area = pi * (raio ** 2)
    print(f'A={area:.4f}')

if __name__ == '__main__':
    main()
