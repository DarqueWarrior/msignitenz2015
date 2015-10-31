Set-ExecutionPolicy unrestricted -Scope CurrentUser -Force  

# Setup the dnx and add it to your current path 
dnvm setup 

# Set runtime to use 
dnvm use 1.0.0-beta8 

# Run the test 
dnx test 
