@echo off
bundler\SqlBundler.exe ..\..\..\..\..\ "db/PostgreSQL/2.x/2.0/db" true
copy hrm.sql hrm-sample.sql
del hrm.sql
copy hrm-sample.sql ..\..\hrm-sample.sql