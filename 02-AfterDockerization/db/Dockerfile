FROM mysql:8.3.0
EXPOSE 3308
COPY ./DockerFromZeroToMastery-ASP.NET-8/db/migrations/ /home/database/
COPY ./DockerFromZeroToMastery-ASP.NET-8/db/dataset/ /home/database/
COPY ./DockerFromZeroToMastery-ASP.NET-8/ci/init_database.sh /docker-entrypoint-initdb.d/init_database.sh
RUN touch teste00.txt

