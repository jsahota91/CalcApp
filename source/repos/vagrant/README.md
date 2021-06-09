# Create Vagrant file
Inside the vagrant directory, I create a Vagrantfile and had the following code

Vagrant.configure("2") do |config|

config.vm.box = "ubuntu/xenial64"
config.vm.network "private_network", ip: "192.168.10.100"

end

## Vagrant commands
- *vagrant up* : This will launch the virtual machine
- *vagrant status* : This ensure the VM is running
- *vagrant ssh* : This ensures the SSH access to the running VM
- *sudo apt-get update -y* : This updates the VM, apt-get is the install manager and -y basically gets all the permissions
- *sudo apt-get install nginx* : This install the nginx

# Verify the nginx
- In the browser you need to type in the ip address: 192.168.10.100
- Doing this will launch the nginx page

# Other commands
- *vagrant destroy* : This will stop the VM and destroy the vagrant
- *vagrant suspend* : This will stop the VM however the config will be kept
- *vagrant reload* : This will reload the vagrant
- *exit* : This will exit out of the vagrant
