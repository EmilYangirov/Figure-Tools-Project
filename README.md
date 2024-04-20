# Figure-Tools-Project
MindBox test task


Задание 1: проект библиотеки для обсчета фигур и проект, реализующий данную библиотеку, в репозитории.

Задание 2: 


-- create products table

CREATE TABLE product (
  id int PRIMARY KEY,
  name varchar(100)
);

-- create category table

CREATE TABLE category (
  id int PRIMARY KEY,
  name varchar(100)
);

-- create product-category-table

CREATE TABLE productsCategories
(
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES product(id),
    FOREIGN KEY (category_id) REFERENCES category(id)
);

-- add categories

INSERT INTO category (id, name) VALUES 
(1, 'smartphone'),
(2, 'desktop'),
(3, 'notebook'),
(4, 'tablet');

-- add products

INSERT INTO product (id, name) VALUES 
(1, 'iPad'),
(2, 'iPhone'),
(3, 'iMac'),
(4, 'macbook'),
(5, 'iChineeseTransformerBook'),
(6, 'iStrangeChineeseGadjet');

-- add links

-- ipad: tablet

INSERT INTO productsCategories (product_id, category_id) VALUES (1, 4);

-- iphone: smartphone

INSERT INTO productsCategories (product_id, category_id) VALUES (2, 1);
-- imac: desktop

INSERT INTO productsCategories (product_id, category_id) VALUES (3, 2);

-- macbook: notebook

INSERT INTO productsCategories (product_id, category_id) VALUES (4, 3);

-- ichineesetransformerbook: tablet и notebook

INSERT INTO productsCategories (product_id, category_id) VALUES (5, 4);

INSERT INTO productsCategories (product_id, category_id) VALUES (5, 3);

-- Query

SELECT p.name as product, ISNULL(c.name, "without category") as category

FROM product p

Left JOIN productsCategories pc ON p.id = pc.product_id

Left JOIN category c ON c.id = pc.category_id
