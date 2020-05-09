--
-- PostgreSQL database dump
--

-- Dumped from database version 12.2
-- Dumped by pg_dump version 12.2

-- Started on 2020-05-09 22:40:29

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 2817 (class 1262 OID 24625)
-- Name: devops; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE devops WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Turkish_Turkey.1254' LC_CTYPE = 'Turkish_Turkey.1254';


ALTER DATABASE devops OWNER TO postgres;

\connect devops

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 202 (class 1259 OID 24629)
-- Name: Counter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Counter" (
    count integer
);


ALTER TABLE public."Counter" OWNER TO postgres;

--
-- TOC entry 2811 (class 0 OID 24629)
-- Dependencies: 202
-- Data for Name: Counter; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Counter" VALUES (0);


-- Completed on 2020-05-09 22:40:29

--
-- PostgreSQL database dump complete
--

