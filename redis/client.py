import redis

with redis.Redis() as  redis_client:
    val = redis_client.brpop("numbers")
print(int(val[1]))