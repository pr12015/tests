@echo off

net localgroup "Krompir" /add

net user "ClientUser" "12345" /add

net localgroup "Krompir" "ClientUser" /add

WMIC USERACCOUNT WHERE "Name='ClientUser'" SET PasswordExpires=FALSE

WMIC USERACCOUNT WHERE "Name='ClientUser'" SET Passwordchangeable=FALSE