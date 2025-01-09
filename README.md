#### how can we check the ECR image layers or instructions in AWS

* aws configure or notepad ~/.aws/credentials
*  aws s3 ls
*   notepad ~/.aws/credentials
*  aws s3 ls
*  aws ecr describe-repositories
*  aws ecr list-images --repository-name <repository-name>

##### goto aws ecr select the repo and specific image  we get some push options therre we get some aws configure with username and password , 
after that we  have some push image command we use pull 

* go to terminal 

* docker image ls

* docker history <repo-name>:<image tag>


