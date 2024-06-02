class estoque:

    def __init__(self, nome, codigo, quantidade, preco):    # construtor
        self.nome = nome
        self.codigo = codigo
        self.quantidade = quantidade
        self.preco = preco

    def get_nome(self):                         # get nome
        return self.nome
    
    def get_codigo(self):                       # get codigo
        return self.codigo

    def get_quantidade(self):                   # get quantidade
        return self.quantidade

    def get_preco(self):                        # get preco
        return self.preco

    def set_nome(self, nome):                   # set nome
        self.nome = nome

    def set_codigo(self, codigo):               # set codigo
        self.codigo = codigo

    def set_quantidade(self, quantidade):       # set quantidade
        self.quantidade = quantidade

    def set_preco(self, preco):                 # set preco
        self.preco = preco

    def subtrair_estoque(self, quantidade):     # subtrair estoque
        self.quantidade -= quantidade
        return self.quantidade

    def __str__(self):                          # string
        return f'Nome: {self.nome}\nCodigo: {self.codigo}\nQuantidade(Un): {self.quantidade}\nPreço(R$): {(self.preco):.2f}'
    
    
    
    