Default URL

http://localhost:54007/graphql/

Sample Query

query {
  news{
    id,title,description,publishedOn
  }
}

{
  "data": {
    "news": [
      {
        "id": "66e743d6-3d4d-44e1-847b-019c59e648f8",
        "title": "Adelide Test",
        "description": "Sachin out",
        "publishedOn": "2018-12-14"
      }
    ]
  }
}
