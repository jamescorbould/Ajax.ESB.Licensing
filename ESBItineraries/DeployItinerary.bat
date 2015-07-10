echo off

set esbToolkitPath="C:\Program Files (x86)\Microsoft BizTalk ESB Toolkit\Bin"
set logFile=".\Log"

if not exist %logFile% mkdir %logFile%

echo ***
echo *** >> %logFile%

echo Import Ajax itinerary
echo Import Ajax itinerary >> %logFile%

esbimportutil /f:Ajax.xml /c:deployed >> %logFile%

echo Import done
echo Import done >> %logFile%

echo ***
echo *** >> %logFile%

pause