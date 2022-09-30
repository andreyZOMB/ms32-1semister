a = '192.168.3.1'
b = a.split('.')
c=[]
e = {''}
e.pop()
for i in b:
    print((i+'                   ')[0:10],end='')
print()
for i in b:
    print(('0000000000'+bin(int(i))[2::]+'   ')[-11:-1],end='')
