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
        "id": "d0e16e84-dba8-47e0-852e-d789006f6af7",
        "title": "Happy News :)",
        "description": "Sample News",
        "publishedOn": "2018-12-14"
      }
    ]
  }
}
