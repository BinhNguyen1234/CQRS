CREATE TABLE AppUser (
    Id UUID PRIMARY KEY
    last_name VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    hash_password TEXT NOT NULL,
    regist_user_id UUID FOREIGN KEY NOT NULL,
    updated_user_id UUID FOREIGN KEY NOT NULL,
    regist_date TIMESTAMPTZ  NOT NULL,
    updated_date TIMESTAMPTZ NOT NULL,
)