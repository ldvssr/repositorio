import pandas as pd
from agent import *
from calculate import *
import random
# responder
def threshold():
    return round(random.uniform(0.1, 1), 1)
# proponent
def threshold1():
    return round(random.uniform(0.1, 0.8), 1)
agent_list = []
for n in range(0, 20):
    if n < 10:
        type_of_agent = 0 # proponent
        ag = agent(n, threshold1(), type_of_agent)
    else:
        type_of_agent = 1 # responder
        ag = agent(n, threshold(), type_of_agent)
    agent_list.append(ag)
file = open('analysis.csv', 'w+')
file.writelines('value,proposed,result\n')
counter = 10000
while counter > 0:
    proponent = random.randint(0, 9)
    responder = random.randint(10, 19)
    value = random.randint(1000, 100000)
    result = agent_list[proponent].get_to_business(file, value, agent_list[responder])
    counter -= 1
data = pd.read_csv('analysis.csv')
data_true = data[data['result'] == 1]
file = open('analysis_ml.csv', 'w+')
file.writelines('id,value,proposed,result\n')
counter = 10000
while counter > 0:
    proponent = random.randint(0, 9)
    responder = random.randint(10, 19)
    value = random.randint(1000, 10000)
    result = agent_list[proponent].get_to_business_2(file, value, agent_list[responder], data_true)
    counter -= 1
