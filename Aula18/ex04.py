from datetime import datetime

class Contato:
  def __init__(self, nome, fone, nascimento):
    self.__Nome = nome
    self.__Fone = fone
    self.__Nasc = datetime.strptime(nascimento, "%d/%m/%Y")
  def __str__(self):
    return self.__Nome + " - " + self.__Fone + " - " + self.__Nasc.strftime("%d/%m/%Y")
  def GetNascimento(self):
    return self.__Nasc
   

class Agenda:
  def __init__(self):
    self.__lista = []
  def Inserir(self, contato):
    self.__lista.append(contato)
  def Listar(self):
    return self.__lista
  def Aniversariantes(self, mes):
    r = []
    for contato in self.__lista:
      if contato.GetNascimento().month == mes:
        r.append(contato)
    return r    

a = Contato("José", "12345678", "29/10/2000")
b = Contato("Maria", "87654321", "29/11/2000")
c = Contato("João", "88884444", "19/10/2010")

agenda = Agenda()
agenda.Inserir(a)
agenda.Inserir(b)
agenda.Inserir(c)

print("Todos os contatos")
for contato in agenda.Listar():
  print(contato)

print("Aniversariantes de outubro")
for contato in agenda.Aniversariantes(10):
  print(contato)
  
