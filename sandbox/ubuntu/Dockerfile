FROM ubuntu:latest

COPY script.sh /opt/script.sh

RUN apt-get update && \
      apt-get -y install sudo apt-utils wget curl software-properties-common

RUN adduser --disabled-password --gecos '' docker
RUN adduser docker sudo
RUN echo '%sudo ALL=(ALL) NOPASSWD:ALL' >> /etc/sudoers

USER docker

CMD ["sh", "-c", "tail -f /dev/null"]
