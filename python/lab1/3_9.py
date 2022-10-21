a = [10, 2, 30, 100, 10, 50, 11, 30, 15, 7]
b = ['python', 'ruby', 'perl', 'ruby', 'perl', 'python', 'ruby', 'perl']
a.reverse()
b.reverse()
print(len(a)-1-a.index(10))
print(len(b)-1-b.index('ruby'))
