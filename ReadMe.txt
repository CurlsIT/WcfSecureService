This example certs should be installed on local machine, and will work only in scenario, 
where both client and service running on localhost.

You should install SampleClientCertificate and SampleServiceCertificate into LocalMachine/Personal store.
DevCertAuthority is the root certificate for them, so it have to be added to Trusted Root Certification Authorities on Local Computer.

PASSWORD: 123

You should also activate port 3018 for SSL with service certificate:
netsh http add sslcert ipport=0.0.0.0:3019 certhash=‎8442a0463febc66f3106f77722bba15702a164df appid={627e9a55-cd33-4d4d-8e33-f96e3d5e0ec5} clientcertnegotiation=enable

That command should be run from Developer Command Prompt for VS2015 (with admin rights).

---------------------------------------------------------------------------------------------------------------------
FOR SECURITY PURPOSES YOU SHOULD REMOVE THEM FROM CERTIFICATE STORES IMMEDIATELY AFTER PLAYING WITH THOSE EXAMPLES!
---------------------------------------------------------------------------------------------------------------------