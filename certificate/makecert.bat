makecert.exe -sr LocalMachine -ss MY -a sha1 -n CN=WCFServer -sky exchange -pe
certmgr.exe -add -r LocalMachine -s My -c -n WCFServer -r CurrentUser -s TrustedPeople
