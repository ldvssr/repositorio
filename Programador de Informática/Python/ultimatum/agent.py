import pandas as pd
from calculate import *
class agent:
    def __init__(self, id, base_threshold, type_of_agent):
        self.id = id
        self.base_threshold = base_threshold
        self.type_of_agent = type_of_agent
        self.total_earned = 0
        self.total_not_earned = 0
    def get_to_business(self, file, value, offeree):
        offer_value = value * self.base_threshold
        result = offeree.make_offer(value, offer_value)
        if result == True:
            res = 1
        else:
            res = 0
        file.writelines(f'{value}, {round(value*self.base_threshold, 2)}, {res}\n')
        return result
    def make_offer(self, value, offer):
        if offer / value < self.base_threshold:
            self.total_not_earned += offer
            return False
        else:
            self.total_earned += offer
            return True
    def get_to_business_2(self, file, value, offeree, dset):
        calc = calculate()
        offer_value = calc.calc_offer(dset, value)
        result = offeree.make_offer(value, offer_value)
        if result == True:
            self.total_earned += offer_value
            res = 1
        else:
            self.total_not_earned += offer_value
            res = 0
        file.writelines(f'{self.get_id()}, {value}, {round(value*self.base_threshold, 2)}, {res}\n')
        return result
    def get_id(self):
        return self.id
    def get_base_threshold(self):
        return self.base_threshold
    def get_total_earned(self):
        return self.total_earned
    def get_total_not_earned(self):
        return self.total_not_earned
