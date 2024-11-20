merge
git init
git add .
git commit -m "abc"
git checkout -b a
git add .
git commit -m "def"
git checkout master
git checkout -b b
git add .
git commit -m "gh"
git checkout a
git merge b


DOCKER

Installing Docker on Ubuntu - go to official website (Docker docs)

mkdir fapp2
touch app.py

app.py
from flask import Flask
app=Flask(__name__)
@app.route('/')
def run():
    return "hello,welcome"
app.run('0.0.0.0',5000)

touch Dockerfile

Dockerfile
FROM python:3.10
WORKDIR /app
COPY . /app
RUN pip install -r requirements.txt
EXPOSE 5000
CMD ["python3","app.py"]


touch requirements.txt

requirements.txt
Flask==2.0.1
Werkzeug==2.0.1

docker build -t fapp2 .

docker run -p 5000:5000 fapp2


SSH

ssh username@hostname_or_ip_address

If key pair not generated already

ssh-keygen 
ssh-copy-id username@hostname_or_ip_address
ssh username@hostname_or_ip_address
 


JENKINS

sudo apt-get install jenkins
sudo apt-get install fontconfig openjdk-17-jre (if Java doesnt exist)

sudo systemctl start jenkins
sudo systemctl status jenkins

Go to https://localhost:8080 - default Jenkins server

It will ask for the authentication key. Copy the path and use command

sudo cat “paste_the_path_here”

Paste the key from terminal to the Jenkins server

Create an account with username and password

—------------------------------------------------------------------------

Create a repository with a Java file
For eg: https://github.com/ssnlabs/jenkins.git

Jenkins
Click New Item
Give a name and select Freestyle Project
 Select Github project and paste repository name






	



















Select Git, Under Credentials, Click Add & Jenkins
Change “Branch Specifier” to */main














	
Enter your github username and password









Add * * * * * under Build Periodically -> Schedule (Cron Job - triggers a build every minute)









Under Build Step -> Select Execute Shell and enter the following









Give Save and Build Now in next page
Enjoy! 
