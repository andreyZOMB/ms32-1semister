c1 = 'switchport trunk allowed vlan 1,3,10,20,30,100'

c2 = 'switchport trunk allowed vlan 1,3,100,200,300'
b1 = c1.strip().split()
b2 = c2.strip().split()
a1 = set(b1[-1].split(','))
a2 = set(b2[-1].split(','))
print(a1 & a2)
