a = 'O 10.0.24.0/24 [110/41] via 10.0.13.3, 3d18h, FastEthernet0/0'
b = a.split()

print(b)
print('Protocol:               OSPF')
print('Prefix:                ',b[1])
print('AD/Metric:             ',b[2][1:-1])
print('Next-Hop:              ',b[4][0:-1])
print('Last update:           ',b[5][0:-1])
print('Outbound Interface:    ',b[6])
