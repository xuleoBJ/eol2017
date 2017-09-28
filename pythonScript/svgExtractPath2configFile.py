from xml.dom import minidom
import configparser 

config = {
  'svg_file' : 'map//chinaXL.svg',
  'config_file'  : 'chianProvince.ini',
}

svg = minidom.parse(config['svg_file'])
paths = svg.getElementsByTagName('path')
pathItems = {}

for node in paths:
  if node.getAttributeNode('id'):
    path_id = str(node.getAttributeNode('id').nodeValue)
    path = str(node.getAttributeNode('d').nodeValue)
    pathItems[path_id] = path


cfd=open('chinaProvince.ini','w')
conf=configparser.ConfigParser()
conf.add_section('Path')         #add a section

for (d,x) in pathItems.items():
  conf.set('Path',str(d),str(x))  
conf.write(cfd)
cfd.close()	
