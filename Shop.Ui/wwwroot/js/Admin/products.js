var app = new Vue({
    el: '#app',
    data: {
        objectIndex: 0,
        productModel: {
            id: 0,
            name: "Name",
            description: "Description",
            value: 1.99,
            image: ''
        },
        loading: false,
        editing: false,
        products: [],
        file: '',
        showPreview: false,
        imagePreview: ''
    },
    mounted() {
        this.getProducts();
    },
    methods: {

        handleFileUpload(event) {
            this.file = event.target.files[0];
        },

        handleFileUpload() {

            this.file = this.$refs.file.files[0];

            let reader = new FileReader();

            reader.addEventListener("load", function () {
                this.showPreview = true;
                this.productModel.image = reader.result;
                    

            }.bind(this), false);

            if (this.file) {
                if (/\.(jpe?g|png|gif)$/i.test(this.file.name)) {
                    reader.readAsDataURL(this.file);
                }
            }
        },

        createProduct() {
            this.loading = true;
            axios.post('/products', this.productModel)
                .then(res => {
                console.log(res.data);
                this.products.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },

        getProduct(id) {
            this.loading = true;
            axios.get('/products/' + id)
                .then(res => {
                    console.log(res);
                    var product = res.data;
                    this.productModel = {
                        id: product.id,
                        name: product.name,
                        description: product.description,
                        value: product.value,
                        image: product.image
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        getProducts() {
            this.loading = true;
            axios.get('/products')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        updateProduct() {
            this.loading = true;
            axios.put('/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },

        deleteProduct(id, index) {
            this.loading = true;
            axios.delete('/products/' + id)
                .then(res => {
                    console.log(res);
                    this.products.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        newProduct() {
            this.editing = true;
            this.productModel.id = 0;
        },

        editProduct(id, index) {
            this.objectIndex = index;
            this.getProduct(id);
            this.editing = true;
        },

        cancel() {
            this.editing = false;
        }
    },
    computed: {
    },
});