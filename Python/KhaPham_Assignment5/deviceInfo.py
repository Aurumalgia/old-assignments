import socket


def printDeviceInfo():
    hostName = socket.gethostname()
    ipAddress = socket.gethostbyname(hostName)
    print("Host: " + hostName)
    print("IP Address: " + ipAddress)
