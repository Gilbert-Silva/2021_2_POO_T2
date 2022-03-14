class Aluno:
  def __init__(self, nome, curso):
    self.__Nome = nome
    self.__Curso = curso
  def __str__(self):
    return self.__Nome + " - " + self.__Curso
  def SetNome(self, nome):
    self.__Nome = nome
  def GetNome(self):
    return self.__Nome
  def SetCurso(self, curso):
    self.__Curso = curso
  def GetCurso(self):
    return self.__Curso
  
a = Aluno("Savio", "Tads")
b = Aluno("Savio", "Tads")

print(a.GetNome())
print(a.GetCurso())
print(a)
print(b.GetNome())
print(b.GetCurso())
print(b)

a.Diretoria = "Diatinf"
print(a.Diretoria)




