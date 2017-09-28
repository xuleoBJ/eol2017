from xml.dom import minidom
import json
import os
import re

dir_path = os.path.dirname(os.path.realpath(__file__))

fd = open(os.path.join(dir_path,'d.txt'),'r')
d = fd.read()
x =re.split(',|\s',d)
print(x)
print(len(x))

