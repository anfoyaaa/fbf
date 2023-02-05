class Person:
    fullname = None
    age = None

    def __init__(self, move):
        self.move = move
        print('-Такой то Person говорит.')
    def __init__(self, talk):
        self.talk = talk
        print('-Такой то Person говорит.')

    def __init__(self, age):
        self.age = age
        print(age)
ppl = Person()
fullname = 'V.V.Volkov'
age = 34243