package com.gestaocinema.rececionista;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;
import org.springframework.boot.web.servlet.support.SpringBootServletInitializer;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication
@EntityScan(basePackages = {"com.casa.entity"})
@EnableJpaRepositories(basePackages = {"com.casa.repositories"})
@ComponentScan(basePackages= {"com.gestaocinema"})
public class RececionistaApplication extends SpringBootServletInitializer
{
	public static void main(String[] args)
	{
		
		SpringApplication.run(RececionistaApplication.class, args);
						
	}
}
