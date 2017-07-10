#!/usr/bin/python
import requests
from requests.auth import HTTPBasicAuth
import sys

r = requests.get('{0}/cgi/create.cgi?code='.format(sys.argv[1]) + sys.argv[2] + '', auth=HTTPBasicAuth('user', 'password'))

print(r.text)

print("Finished")