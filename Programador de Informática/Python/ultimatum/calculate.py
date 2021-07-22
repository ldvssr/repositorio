import pandas as pd
class calculate:
    def calc_offer(self, ds, base_value):
        floor = base_value * 0.9
        ceilling = base_value * 1.1
        values = ds[ds['value'] >= floor]
        values2 = values[values['value'] <= ceilling]
        offer = values2['proposed'].max() * 0.7
        return offer
