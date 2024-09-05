SELECT
  datname AS database_name,
  pg_size_pretty(pg_database_size(datname)) AS size
FROM
  pg_database;
