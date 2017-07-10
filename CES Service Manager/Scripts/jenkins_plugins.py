#!/usr/bin/env python

import subprocess
import sys

# key may be configured in http://jenkins/me/configure
# For use cli need to configure Jenkins.
# Jenkins -> Configure Global Security a) TCP -> any, b) anyone can do anything

output = (str(subprocess.check_output("java -jar {0}/jenkins-cli.jar -s {1} -i {0}/key.pub \\"
                                      "list-plugins".format(sys.argv[1], sys.argv[2]), shell=True)).split("\\n"))
for i in range(len(output)):
    print(output[i])