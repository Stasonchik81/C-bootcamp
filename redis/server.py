import redis
import random

with redis.Redis() as redis_server:
    redis_server.lpush("numbers", random.randint(1, 10))
