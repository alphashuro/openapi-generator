=begin
#OpenAPI Petstore

#This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.1.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for Petstore::NumberOnly
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe Petstore::NumberOnly do
  let(:instance) { Petstore::NumberOnly.new }

  describe 'test an instance of NumberOnly' do
    it 'should create an instance of NumberOnly' do
      expect(instance).to be_instance_of(Petstore::NumberOnly)
    end
  end
  describe 'test attribute "just_number"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
