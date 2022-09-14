# dotnet-graphql

- run docker-compose, apply migrations, run the application project

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

- Get category by id
query CategoryQuery{ 
  categoryById(id: 5) {
    categoryId 
    name 
    urlImage
  }
}

- Delete category
mutation CategoryService{
  deleteCategory(id: 6)
}

- Update category
mutation CategoryService{
  updateCategory(request: {
    categoryId: 7
    name: "name updated"
    urlImage: "url updated"
  }){
    categoryId
    name
    urlImage
  }
}
