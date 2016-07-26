# Verisurf API - Python 3.4 Example

import socket

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM) 

host = socket.gethostname()                           
port = 33666

s.connect((host, port))                               

tm = s.recv(1024)                                     
print("SERVER: %s" % tm.decode('ascii'))

s.send("<command_list />\n".encode('ascii'))

tm = s.recv(1024)                                     
print("SERVER: %s" % tm.decode('ascii'))

s.close()