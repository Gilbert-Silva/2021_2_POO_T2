class Pessoa:
  def __init__(self, nome):
    self.__Nome = nome
  def __str__(self):
    return self.__Nome
  def SetNome(self, nome):
    self.__Nome = nome
  def GetNome(self):
    return self.__Nome