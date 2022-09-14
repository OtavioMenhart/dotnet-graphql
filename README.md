# dotnet-graphql
- Add Category:
mutation CategoryService{
  addCategory(request: {
    name: "name test"
    urlImage: "any string"
  }){
    categoryId
  }
}

- Get all categories:
query CategoryQuery{
  allCategories{
    categoryId
    name
    urlImage
  }
}
