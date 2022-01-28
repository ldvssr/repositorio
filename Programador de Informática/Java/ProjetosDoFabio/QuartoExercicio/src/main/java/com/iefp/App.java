package com.iefp;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;
import org.springframework.boot.web.servlet.support.SpringBootServletInitializer;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.scheduling.annotation.EnableScheduling;
import org.springframework.scheduling.annotation.Scheduled;

@SpringBootApplication
@ComponentScan(basePackages = {"com.iefp"})
@EntityScan(basePackages = {"com.iefp.entity"} )
@EnableJpaRepositories(basePackages = {"com.iefp.repositories"})
public class App  extends SpringBootServletInitializer {
	

	
    public static void main(String[] args) {
        SpringApplication.run(App.class, args);
        
    }
    

}