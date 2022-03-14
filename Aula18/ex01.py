def dobro(valor):
  return valor + valor;

x = 5
print(x)
print(type(x))
print(dobro(x))
print(type(dobro))
print(id(x))
y = 5
z = 10
print(id(y))
print(id(z))
y = 10
print(id(y))

class Aluno:
  pass

a = Aluno()
b = Aluno()

print(a)
print(b)
print(id(a))
print(id(b))

a.Nome = "Savio"
b.Curso = "TADS"

print(a.Nome)
print(a.Curso)
print(b.Curso)

