class Phone:
    number = None
    model = None
    weight = None

    def __init__(self):
        pass

    def __init__(self, number, model, weight):
        self.set_data(number, model, weight)


    def set_data(self, number = None, model = None, weight = None):
        self.number = number
        self.model = model
        self.weight = weight

    def get_data(self):
        print('number: ', self.number, 'model :', self.model, 'weight :', self.weight)

    def receiveCall(self, name):
        self.name = name
        print("Вас звонит:", name)

    def getNumber(self,):
        print(Phone1.number, Phone2.number, Phone3.number)

Phone1= Phone(9458784, 'mgvdls', 43 )
Phone1.number = 9458784
Phone1.model = 'mgvdls'
Phone1.weight = 43

Phone2 = Phone(9458784, 'mgvdls', 43)
Phone2.number = 9458784
Phone2.model = 'mgvdls'
Phone2.weight = 43

Phone3 = Phone(9458784, 'mgvdls', 43)
Phone3.number = 9458784
Phone3.model = 'mgvdls'
Phone3.weight = 43
