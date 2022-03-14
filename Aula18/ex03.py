from pessoa import Pessoa

class Aluno(Pessoa):
  def __init__(self, nome, curso):
    super().__init__(nome)
    self.__Curso = curso
  def __str__(self):
    return super().__str__() + " - " + self.__Curso
  def SetCurso(self, curso):
    self.__Curso = curso
  def GetCurso(self):
    return self.__Curso

class Professor(Pessoa):
  def __init__(self, nome, diretoria):
    super().__init__(nome)
    self.__Diretoria = diretoria
  def __str__(self):
    return super().__str__() + " - " +  self.__Diretoria
  def SetDiretoria(self, diretoria):
    self.__Curso = diretoria
  def GetDiretoria(self):
    return self.__Diretoria
  
a = Aluno("Savio", "Tads")
b = Aluno("Savio", "Tads")

x = Professor("Eduardo", "Diatinf")
y = Professor("Jorgiano", "Diatinf")

print(a.GetNome())
print(b.GetNome())

print(x)
print(y)
