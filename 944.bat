@echo off
For /f "tokens=2-4 delims=/ " %%a in ('date /t') do (set mydate=%%c-%%a-%%b)
For /f "tokens=1-2 delims=/:" %%a in ('time /t') do (set mytime=%%a%%b)
@echo on
m:
CD m:944/Course_944
git add *
git commit -m "%mydate%_%mytime%"
git push
pause